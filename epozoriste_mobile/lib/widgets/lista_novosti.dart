import 'package:flutter/material.dart';
import '../models/models.dart';

class ListaNovosti extends StatelessWidget{
  final List<Obavijest> obavijesti;
  const ListaNovosti({super.key, required this.obavijesti});

  @override
  Widget build(BuildContext context){
    return ListView.builder(
      itemCount: obavijesti.length,
      scrollDirection: Axis.vertical,
      shrinkWrap: true,
      physics: const NeverScrollableScrollPhysics(),
      itemBuilder: (BuildContext context, int index){
        final obavijest = obavijesti[index];
        return GestureDetector(
          onTap: () => {
            //Navigator.push(context, MaterialPageRoute(
              //builder: (context) => DetaljiNovosti(id: obavijest.obavijestId),
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
                  child: Image.network(obavijest.slika),
                ),
                Column(
                  children: [
                    Text(obavijest.datumKreiranja.toString()),
                    Text(obavijest.naslov),
                    Text(obavijest.podnaslov)
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