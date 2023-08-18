import 'package:flutter/material.dart';

class DetaljiPredstave extends StatefulWidget {
  //final int? id;
  const DetaljiPredstave({super.key});

  @override
  State<DetaljiPredstave> createState() => _DetaljiPredstaveState();
}

class _DetaljiPredstaveState extends State<DetaljiPredstave> {
  @override
  Widget build(BuildContext context) {
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
              Column(
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
                  const SizedBox(height: 60),
                  const Column(
                    children: [
                      Text(
                        "Naziv",
                        style: TextStyle(
                            fontWeight: FontWeight.bold, fontSize: 25),
                      ), //dodati atribute za sve
                      Text("Režija"),
                      Text("Sadržaj"),
                    ],
                  ),
                  const SizedBox(
                    height: 30,
                  ),
                  Container(
                    height: 80,
                    width: double.infinity,
                    decoration: BoxDecoration(
                      color: const Color.fromARGB(255, 102, 98, 98),
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: const Column(children: [
                      Text("Datum, vrijeme"), //dodati atribute za sve
                      Text("Naziv pozorista"),
                      Text("Sala"),
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
                  /*Column(
                  children: [
                    const Text("Datum, vrijeme"), //dodati atribute za sve
                    const Text("Naziv pozorista"),
                    const Text("Sala"),
                    Container(
                      height: 50,
                      width: double.infinity,
                      decoration:BoxDecoration(
                        color: const Color.fromARGB(223, 117, 117, 98),borderRadius: BorderRadius.circular(10),
                      ),
                      child: InkWell(
                        onTap: () async {
                          try{
                            Navigator.pushNamed(context,'/');
                          } catch(e){
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
                  ]
                 ),*/
                ],
              )
            ]),
          ),
        ),
      ),
    );
  }
}
