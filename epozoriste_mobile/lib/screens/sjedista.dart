import 'package:provider/provider.dart';
import '../models/karta.dart';
import '../models/termin.dart';
import 'package:flutter/material.dart';
import '../providers/karta_provider.dart';

class Sjedista extends StatefulWidget {
  final Termin? termin;
  const Sjedista({super.key, this.termin});

  @override
  State<Sjedista> createState() => _SjedistaState();
}

class _SjedistaState extends State<Sjedista> {
  List<Karta> karte = [];
  KartaProvider? _kartaProvider;
  @override
  void initState() {
    super.initState();
    _kartaProvider = context.read<KartaProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _kartaProvider?.get();
    setState(() {
      karte = tempData!;
    });
    for (Karta karta in karte) {
      print(karta.sjediste);
    }
  }

  @override
  Widget build(BuildContext context) {
    Termin? _termin = widget.termin;
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 86, 81, 81),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 57, 53, 53),
        title: const Text(
          'ePozorište',
          style: TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
        ),
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(50),
            child: Column(
              children: [
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      _termin!.predstava.naziv,
                      style: const TextStyle(
                          fontWeight: FontWeight.bold, fontSize: 25),
                    ),
                    Text(
                        '${_termin.datumOdrzavanja.toString().substring(0, 10)}, ${_termin.vrijemeOdrzavanja}'),
                    Text(_termin.sala.naziv),
                  ],
                ),
                const SizedBox(
                  height: 10,
                ),
                Row(
                  children: [
                    Column(
                      children: [
                        Padding(
                            padding: const EdgeInsets.all(8),
                            child: Container(
                                decoration: BoxDecoration(
                                    color: Colors.white,
                                    border: Border.all(
                                        color: Colors.grey,
                                        width: 1.0,
                                        style: BorderStyle.solid),
                                    borderRadius: BorderRadius.circular(4)),
                                width: 20,
                                height: 20)),
                        const Text("Slobodno"),
                      ],
                    ),
                    const SizedBox(
                      width: 10,
                    ),
                    Column(
                      children: [
                        Padding(
                            padding: const EdgeInsets.all(8),
                            child: Container(
                                decoration: BoxDecoration(
                                    color: const Color.fromARGB(
                                        255, 172, 168, 168),
                                    border: Border.all(
                                        color: Colors.grey,
                                        width: 1.0,
                                        style: BorderStyle.solid),
                                    borderRadius: BorderRadius.circular(4)),
                                width: 20,
                                height: 20)),
                        const Text("Izabrano"),
                      ],
                    ),
                    const SizedBox(
                      width: 10,
                    ),
                    Column(
                      children: [
                        Padding(
                            padding: const EdgeInsets.all(8),
                            child: Container(
                                decoration: BoxDecoration(
                                    color: const Color.fromARGB(
                                        255, 195, 178, 178),
                                    border: Border.all(
                                        color: Colors.grey,
                                        width: 1.0,
                                        style: BorderStyle.solid),
                                    borderRadius: BorderRadius.circular(4)),
                                width: 20,
                                height: 20)),
                        const Text("Rasprodano"),
                      ],
                    ),
                  ],
                ),
                SizedBox(
                  height: 400,
                  child: ListView.builder(
                    itemCount: _termin.sala.brRedova,
                    scrollDirection: Axis.vertical,
                    itemBuilder: (context, index) {
                      final seat = karte[index];
                      final seatColor = seat.aktivna
                          ? Colors.white
                          : const Color.fromARGB(255, 195, 178, 178);

                      return Container(
                        margin: const EdgeInsets.all(8.0),
                        color: seatColor,
                        child: Center(
                          child: Text(seat.sjediste),
                        ),
                      );
                    },
                  ),
                ),
              ],
            ),
            /*GridView.builder(
                  gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
                    crossAxisCount:
                        4, // Number of seats per row //_termin.sala.brSjedistaPoRedu
                  ),
                  itemCount: karte.length,
                  itemBuilder: (context, index) {
                    final seat = karte[index];
                    final seatColor = seat.aktivna
                        ? Colors.white
                        : const Color.fromARGB(255, 195, 178, 178);

                    return Container(
                      margin: const EdgeInsets.all(8.0),
                      color: seatColor,
                      child: Center(
                        child: Text(seat.sjediste),
                      ),
                    );
                  },
                ),*/
          ),
        ),
      ),
    );
  }
}
