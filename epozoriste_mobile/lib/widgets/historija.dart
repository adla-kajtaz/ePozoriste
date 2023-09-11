import 'package:flutter/material.dart';

class Historija extends StatelessWidget {
  const Historija({super.key});

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: 1,
        scrollDirection: Axis.vertical,
        itemBuilder: (BuildContext context, int index) {
          // final kupovina = kupovine[index];
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
                  const Expanded(
                    child: Padding(
                      padding: EdgeInsets.all(10.0),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "Bilo jednom",
                            style: TextStyle(
                                fontWeight: FontWeight.bold, fontSize: 16),
                          ),
                          Text(
                            "19.09.2022., 20:00",
                            style: TextStyle(fontSize: 12),
                          ),
                          Text(
                            "Broj karata: 5",
                            style: TextStyle(fontSize: 15),
                          ),
                          Text(
                            "Cijena: 250KM",
                            style: TextStyle(fontSize: 15),
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
