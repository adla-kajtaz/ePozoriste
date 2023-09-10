import 'package:flutter/material.dart';
import '../models/models.dart';

class PrikazSjedista extends StatelessWidget {
  final List<Karta> karte;
  const PrikazSjedista({super.key, required this.karte});

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: karte.length,
        scrollDirection: Axis.vertical,
        itemBuilder: (BuildContext context, int index) {
          final karta = karte[index];
          return GestureDetector(
            child: Container(
              margin: const EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              height: 150,
              decoration: BoxDecoration(
                color: const Color.fromARGB(255, 95, 94, 94),
                borderRadius: BorderRadius.circular(15),
              ),
              child: Row(
                children: [
                  Container(
                    height: 150,
                    width: 120,
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: ClipRRect(
                      borderRadius: const BorderRadius.only(
                        topLeft: Radius.circular(10),
                        bottomLeft: Radius.circular(10),
                      ),
                      child: Image.network(
                          "https://www.npm.ba/images/celavapjevacica/npm-celava-pjevacica-naslovna.jpg",
                          fit: BoxFit.cover),
                      //Image.network(termin.predstava.slika as String),
                    ),
                  ),
                  Expanded(
                    child: Padding(
                      padding: const EdgeInsets.all(10.0),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            karta.sjediste,
                            style: const TextStyle(
                                fontWeight: FontWeight.bold, fontSize: 16),
                          ),
                        ],
                      ),
                    ),
                  ),
                ],
              ),
            ),
          );
        });
  }
}
