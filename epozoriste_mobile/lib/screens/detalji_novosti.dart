import 'package:epozoriste_mobile/models/obavijest.dart';
import 'package:flutter/material.dart';

class DetaljiNovosti extends StatefulWidget {
  final Obavijest? obavijest;
  const DetaljiNovosti({super.key, this.obavijest});

  @override
  State<DetaljiNovosti> createState() => _DetaljiNovostiState();
}

class _DetaljiNovostiState extends State<DetaljiNovosti> {
  @override
  Widget build(BuildContext context) {
    Obavijest? _obavijest = widget.obavijest;
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
            child: Column(children: [
              Container(
                height: 50,
                width: double.infinity,
                child: Transform.scale(
                  scale: 3.0,
                  child: Image.network(
                      "https://www.npm.ba/images/celavapjevacica/npm-celava-pjevacica-naslovna.jpg"), //dodati atribut
                ),
              ),
              const SizedBox(height: 60),
              Column(
                children: [
                  Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        _obavijest!.naslov,
                        style: const TextStyle(
                            fontWeight: FontWeight.bold, fontSize: 20),
                      ),
                      Row(
                        children: [
                          Text(_obavijest.korisnik.korisnickoIme.toString()),
                          const Text(" | "),
                          Text(_obavijest.datumKreiranja
                              .toString()
                              .substring(0, 10)),
                        ],
                      ),
                      const SizedBox(height: 5),
                      Text(_obavijest.podnaslov),
                      const SizedBox(height: 10),
                      Text(_obavijest.sadrzaj),
                    ],
                  ),
                  const SizedBox(
                    height: 30,
                  ),
                ],
              ),
            ]),
          ),
        ),
      ),
    );
  }
}
