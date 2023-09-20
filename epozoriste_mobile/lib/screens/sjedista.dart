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
  List<Karta>? izabranaSjedista = [];
  // List<int> kolone = [];
  // List<int> redovi = [];
  KartaProvider? _kartaProvider;
  @override
  void initState() {
    super.initState();
    _kartaProvider = context.read<KartaProvider>();
    loadData();
  }

  Future loadData() async {
    Termin? _termin = widget.termin;

    var tempData = await _kartaProvider?.getByTerminId(_termin!.terminId);
    setState(() {
      karte = tempData!;
      /* kolone = List<int>.generate(_termin!.sala.brSjedistaPoRedu, (i) => i + 1);
      redovi = List<int>.generate(_termin!.sala.brRedova, (i) => i + 1); */
    });
    for (Karta karta in karte) {
      print(karta.sjediste);
    }
  }

  @override
  Widget build(BuildContext context) {
    Termin? _termin = widget.termin;
    if (karte.isEmpty) {
      return Scaffold(
        backgroundColor: const Color.fromARGB(255, 86, 81, 81),
        resizeToAvoidBottomInset: false,
        appBar: AppBar(
          automaticallyImplyLeading: false,
          backgroundColor: const Color.fromARGB(255, 57, 53, 53),
          leading: IconButton(
            icon: const Icon(Icons.arrow_back_ios_new_rounded,
                color: Color.fromARGB(225, 195, 178, 178)),
            onPressed: () => Navigator.of(context).pop(),
          ),
          title: const Text(
            'Profil',
            style: TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
          ),
        ),
        body: const Center(
          child: Text(
            'Učitavanje ...',
            style: TextStyle(
              color: Color.fromARGB(225, 195, 178, 178),
            ),
          ),
        ),
      );
    }
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 86, 81, 81),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 57, 53, 53),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back_ios_new_rounded,
              color: Color.fromARGB(225, 195, 178, 178)),
          onPressed: () => Navigator.of(context).pop(),
        ),
        title: const Text(
          'ePozorište',
          style: TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
        ),
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(50),
            child: Column(children: [
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
                                  color:
                                      const Color.fromARGB(255, 172, 168, 168),
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
                                  color:
                                      const Color.fromARGB(255, 195, 178, 178),
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
                height: 600,
                width: double.infinity,
                child: Padding(
                  padding: const EdgeInsets.all(5.0),
                  child: Row(
                    children: [
                      Expanded(
                        child: GridView.count(
                          crossAxisCount: 10,
                          children: List.generate(karte!.length, (index) {
                            final seat = karte[index];
                            return InkWell(
                                onTap: () {
                                  if (!seat.aktivna) {
                                    showMessage("Seat already taken");
                                  } else if (izabranaSjedista!
                                      .contains(karte![index])) {
                                    setState(() {
                                      izabranaSjedista!.remove(karte![index]);
                                    });
                                  } else {
                                    setState(() {
                                      izabranaSjedista!.add(karte![index]);
                                    });
                                  }
                                },
                                child: Container(
                                  width: 80,
                                  height: 80,
                                  decoration: BoxDecoration(
                                      border: Border.all(
                                          color: Colors.grey,
                                          width: 1.0,
                                          style: BorderStyle.solid),
                                      borderRadius: BorderRadius.circular(4),
                                      color: (izabranaSjedista!
                                              .contains(karte![index]))
                                          ? const Color.fromARGB(
                                              255, 172, 168, 168)
                                          : (seat.aktivna)
                                              ? Colors.white
                                              : const Color.fromARGB(
                                                  255, 195, 178, 178)),
                                  margin: const EdgeInsets.all(5),
                                  child: Center(
                                    child: Text(
                                      seat.sjediste,
                                      style: const TextStyle(fontSize: 6),
                                    ),
                                  ),
                                ));
                          }),
                        ),
                      ),
                    ],
                  ),
                ),
              ),
              /* const SizedBox(
                height: 10,
              ),
              Container(
                height: 50,
                width: 200,
                decoration: BoxDecoration(
                  color: const Color.fromARGB(223, 217, 217, 217),
                  borderRadius: BorderRadius.circular(10),
                ),
                child: InkWell(
                  onTap: () async {
                    try {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (context) => Sjedista(termin: _termin),
                        ),
                      );
                    } catch (e) {
                      print(e.toString());
                    }
                  },
                  child: const Center(
                    child: Text(
                      'Dalje',
                      style: TextStyle(
                        color: Color.fromARGB(225, 86, 81, 81),
                        fontSize: 20,
                      ),
                    ),
                  ),
                ),
              ), */
            ]),
          ),
        ),
      ),
    );
  }

  showMessage(String message) {
    return showDialog(
        context: context,
        builder: (BuildContext context) => AlertDialog(
              title: const Text("Message"),
              content: Text(message),
              actions: [
                TextButton(
                    child: const Text("Ok"),
                    onPressed: () => Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) =>
                                Sjedista(termin: widget.termin),
                          ),
                        ))
              ],
            ));
  }
}
