import 'package:provider/provider.dart';

import '../models/karta.dart';
import '../models/termin.dart';
import 'package:flutter/material.dart';

import '../providers/karta_provider.dart';
import '../widgets/prikaz_sjedista.dart';

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
                /*PrikazSjedista(
                  karte: karte,
                ),*/
              ],
            ),
          ),
        ),
      ),
    );
  }
}
