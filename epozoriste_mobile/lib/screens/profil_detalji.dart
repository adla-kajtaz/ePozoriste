import 'package:flutter/material.dart';

class DetaljiProfila extends StatefulWidget{
  //final int? id;
  const DetaljiProfila({super.key});
  
  @override
  State<DetaljiProfila> createState() => _DetaljiProfilaState();
}

class _DetaljiProfilaState extends State<DetaljiProfila>{
   final formKey = GlobalKey<FormState>();
    String? ime;
   String? prezime;
    String? korisnickoIme;
    String? email;
    String? brTelefona;
    String? lozinka;
    String? lozinkaProvjera;

  @override
  Widget build(BuildContext context){
  return Scaffold(
    backgroundColor: const Color.fromARGB(255, 86, 81, 81),
    resizeToAvoidBottomInset: false,
    appBar: AppBar(
            automaticallyImplyLeading: false,
             backgroundColor: const Color.fromARGB(255, 57, 53, 53),
            title: const Text(
              'Ime korisnika', 
              style: TextStyle(
                color: Color.fromARGB(225, 195, 178, 178)
                ),
                ),
          ),
          body: SingleChildScrollView(
      child: SafeArea(
      child: Padding(
        padding: const EdgeInsets.all(50),
        child: Form(
          child: Column(
            children:[
              TextFormField(
                      onSaved: (newValue) => korisnickoIme = newValue,
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
          TextFormField(
                      onSaved: (newValue) => email = newValue,
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => ime = newValue,
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => prezime = newValue,
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => brTelefona = newValue,
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                  const SizedBox(height: 10),
                    InkWell(
                      onTap: () async {
                        /*if(formKey.currentState!.validate()){
                          formKey.currentState!.save();
                        }*/
                        try{
                          Navigator.pushNamed(context, '/login');

                        } on Exception catch(err){
                          print(err.toString());
                          //formKey.currentState!.validate();
                        }
                      },
                      child: Container(
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color:const Color.fromARGB(223, 117, 117, 98),
                        ),
                        height: 50,
                        child: const Center(
                          child: Text(
                            'Odjavi se',
                            style: TextStyle(
                              color: Colors.white,
                              fontSize: 20
                            ),
                          ),
                        ),
                      ),
                    ),  
                    const SizedBox(height: 10),
                    InkWell(
                      onTap: () async {
                        /*if(formKey.currentState!.validate()){
                          formKey.currentState!.save();
                        }*/
                        try{
                          Navigator.pushNamed(context, '/');

                        } on Exception catch(err){
                          print(err.toString());
                          //formKey.currentState!.validate();
                        }
                      },
                      child: Container(
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color:const Color.fromARGB(223, 117, 117, 98),
                        ),
                        height: 50,
                        child: const Center(
                          child: Text(
                            'Sačuvaj promjene',
                            style: TextStyle(
                              color: Colors.white,
                              fontSize: 20
                            ),
                          ),
                        ),
                      ),
                    ),  
            ]
        ),
        ),
        ),
        ),
    ),
  );
  }
}