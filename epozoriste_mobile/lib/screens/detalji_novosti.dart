import 'package:flutter/material.dart';

class DetaljiNovosti extends StatefulWidget{
  //final int? id;
  const DetaljiNovosti({super.key});
  
  @override
  State<DetaljiNovosti> createState() => _DetaljiNovostiState();
}

class _DetaljiNovostiState extends State<DetaljiNovosti>{

  @override
  Widget build(BuildContext context){
  return  Scaffold(
    backgroundColor: const Color.fromARGB(255, 86, 81, 81),
    resizeToAvoidBottomInset: false,
    appBar: AppBar(
            automaticallyImplyLeading: false,
             backgroundColor: const Color.fromARGB(255, 57, 53, 53),
            title: const Text(
              'ePozorište', 
              style: TextStyle(
                color: Color.fromARGB(225, 195, 178, 178)
                ),
                ),
          ),
    body: SingleChildScrollView(
      child: SafeArea(
      child: Padding(
        padding: const EdgeInsets.all(50),
        child: Column(
          children: [
            Column(
              children: [
                Container(
                  height: 50,
                  width: double.infinity,
                  child: Transform.scale(
                    scale: 3.0,
                    child:
                    Image.network("https://www.npm.ba/images/celavapjevacica/npm-celava-pjevacica-naslovna.jpg"), //dodati atribut
                ),
                ),
                const SizedBox(height: 60),
                const Row(
                  children: [
                    Text("Autor"),
                    Text("|"),
                    Text("Datum"),
                  ],
                ),
                 const Column(  
                  children: [
                    Text("Naslov", style: TextStyle( fontWeight: FontWeight.bold, fontSize: 25),), //dodati atribute za sve
                    Text("Podnaslov"),
                    Text("Sadržaj"),
                  ],
                 ),
                 const SizedBox( 
                        height: 30,
                  ),
              ],
            ),
          ]
        ),
        ),
      ),
    ),
  );
  }
}