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
            child:
                Column(mainAxisAlignment: MainAxisAlignment.start, children: [
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
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      Text(
                        _obavijest!.naslov,
                        style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 20,
                          color: Color.fromARGB(225, 195, 178, 178),
                        ),
                      ),
                      Row(
                        children: [
                          Text(
                            _obavijest.korisnik.korisnickoIme.toString(),
                            style: const TextStyle(
                                color: Color.fromARGB(255, 219, 217, 217)),
                          ),
                          const Text(
                            " | ",
                            style: TextStyle(
                                color: Color.fromARGB(255, 219, 217, 217)),
                          ),
                          Text(
                            _obavijest.datumKreiranja
                                .toString()
                                .substring(0, 10),
                            style: const TextStyle(
                                color: Color.fromARGB(255, 219, 217, 217)),
                          ),
                        ],
                      ),
                      const SizedBox(height: 5),
                      Text(
                        _obavijest.podnaslov,
                        style: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)),
                      ),
                      const SizedBox(height: 10),
                      Text(
                        _obavijest.sadrzaj,
                        style: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)),
                      ),
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
