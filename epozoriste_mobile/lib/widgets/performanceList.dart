import 'package:flutter/material.dart';
import '../models/models.dart';
import '../screens/screens.dart';

class PerformanceList extends StatelessWidget{
  final List<Termin> termini;
  const PerformanceList({super.key, required this.termini});

  @override
  Widget build(BuildContext context){
    return ListView.builder(
      itemCount: termini.length,
      scrollDirection: Axis.vertical,
      shrinkWrap: true,
      physics: const NeverScrollableScrollPhysics(),
      itemBuilder: (BuildContext context, int index){
        final termin = termini[index];
        return GestureDetector(
          onTap: () => {
            //Navigator.push(context, MaterialPageRoute(
              //builder: (context) => DetaljiPredstave(id: termin.terminId),
              //),
             // )
          },
          child: Container(
            margin: const EdgeInsets.symmetric(vertical: 10, horizontal: 10),
            height: 150,
            decoration:  BoxDecoration(
              color:  const Color.fromARGB(255, 86, 81, 81),
              borderRadius: BorderRadius.circular(30),
             ),
             child: Row(
              children: [
                Container(
                  decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),),
                  child: Image.network(termin.predstava.slika as String),
                ),
                Column(
                  children: [
                    Text(termin.datumOdrzavanja.toString()+', '+termin.vrijemeOdrzavanja),
                    Text(termin.predstava.naziv),
                    Text(termin.predstava.sadrzaj)
                  ],
                ),
             ],
             ),
          ),
        );
      }
    );
  }
}