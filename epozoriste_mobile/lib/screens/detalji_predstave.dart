import 'package:flutter/material.dart';
import '../models/termin.dart';

class DetaljiPredstave extends StatefulWidget {
  final Termin? termin;
  const DetaljiPredstave({super.key, this.termin});

  @override
  State<DetaljiPredstave> createState() => _DetaljiPredstaveState();
}

class _DetaljiPredstaveState extends State<DetaljiPredstave> {
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
                  Container(
                    height: 50,
                    width: double.infinity,
                    child: Transform.scale(
                      scale: 3.0,
                      child: Image.network(
                          "https://www.npm.ba/images/celavapjevacica/npm-celava-pjevacica-naslovna.jpg"), //dodati atribut
                    ),
                  ),
                  const SizedBox(
                    height: 60,
                  ),
                  Column(
                    children: [
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            _termin!.predstava.naziv,
                            style: const TextStyle(
                                fontWeight: FontWeight.bold, fontSize: 25),
                          ), //dodati atribute za sve
                          Text("Režija: ${_termin.predstava.rezija}"),
                          Text(
                              "Kostimografija: ${_termin.predstava.kostimografija}"),
                          Text(
                              "Scenografija: ${_termin.predstava.scenografija}"),
                        ],
                      ),
                      const SizedBox(height: 5),
                      Text(_termin.predstava.sadrzaj),
                    ],
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  Container(
                    height: 80,
                    width: double.infinity,
                    decoration: BoxDecoration(
                      color: const Color.fromARGB(255, 102, 98, 98),
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: Column(children: [
                      const SizedBox(
                        height: 7,
                      ),
                      Text(_termin.datumOdrzavanja.toString().substring(0, 10) +
                          ', ' +
                          _termin.vrijemeOdrzavanja), //dodati atribute za sve
                      Text(_termin.sala.pozoriste.naziv),
                      Text(_termin.sala.naziv),
                    ]),
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  Container(
                    height: 50,
                    width: double.infinity,
                    decoration: BoxDecoration(
                      color: const Color.fromARGB(223, 117, 117, 98),
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: InkWell(
                      onTap: () async {
                        try {
                          Navigator.pushNamed(context, '/');
                        } catch (e) {
                          print(e.toString());
                        }
                      },
                      child: const Center(
                        child: Text(
                          'Kupi',
                          style: TextStyle(
                            color: Colors.white,
                            fontSize: 20,
                          ),
                        ),
                      ),
                    ),
                  ),
                ],
              )),
        ),
      ),
    );
  }
}
