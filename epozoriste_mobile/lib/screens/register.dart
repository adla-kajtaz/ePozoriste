import 'package:flutter/material.dart';

class Register extends StatefulWidget{
  const Register({super.key});

  @override
  _RegisterState createState() => _RegisterState();
}

class _RegisterState extends State<Register>{
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
    body: SingleChildScrollView(
      child: SafeArea(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: Column(
          children: [
            const SizedBox(height: 10),
            const Text(
               'ePozoriste',
            style: TextStyle(
              fontSize: 50,
              fontWeight: FontWeight.bold,
              color: Color.fromARGB(225, 195, 178, 178),
            ),
            ),
            const SizedBox(
              height: 10,
              ),
              Form(
                child: Column(
                  children: [
                    Row(
                        children: [
                          Flexible(
                        child: TextFormField(
                        onSaved: (newValue) => ime = newValue,
                        validator: (value) {
                          if(value!.isEmpty){
                           return "Ovo polje je obavezno";
                          }
                        },
                        style: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                        decoration: InputDecoration(
                          border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15)
                          ),
                          labelText: 'Ime',
                          hintText: 'Ime',
                          labelStyle: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)
                          ),
                        ),
                      ),
                      ),
                      const SizedBox(width: 5),
                      Flexible(child: 
                      TextFormField(
                        onSaved: (newValue) => prezime = newValue,
                        validator: (value) {
                          if(value!.isEmpty){
                           return "Ovo polje je obavezno";
                          }
                        },
                        style: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                        decoration: InputDecoration(
                          border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15)
                          ),
                          labelText: 'Prezime',
                          hintText: 'Prezime',
                          labelStyle: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)
                          ),
                        ),
                      ),
                      ),
                      ]
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => email = newValue,
                      validator: (value) {
                        if(value!.isEmpty){
                         return "Ovo polje je obavezno";
                        }
                      },
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelText: 'Email',
                        hintText: 'email@example.com',
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => brTelefona = newValue,
                      validator: (value) {
                        if(value!.isEmpty){
                         return "Ovo polje je obavezno";
                        }
                      },
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelText: 'Broj telefona',
                        hintText: '061-000-000',
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => korisnickoIme = newValue,
                      validator: (value) {
                        if(value!.isEmpty){
                         return "Ovo polje je obavezno";
                        }
                      },
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelText: 'Korisničko ime',
                        hintText: 'korisničko ime',
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => lozinka = newValue,
                      validator: (value) {
                        if(value!.isEmpty){
                         return "Ovo polje je obavezno";
                        }
                      },
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelText: 'Lozinka',
                        hintText: '********',
                        labelStyle: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    TextFormField(
                      onSaved: (newValue) => lozinkaProvjera = newValue,
                      validator: (value) {
                        if(value!.isEmpty){
                         return "Ovo polje je obavezno";
                        }
                      },
                      style: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)
                      ),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(15)
                        ),
                        labelText: 'Provjera lozinke',
                        hintText: '********',
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
                            'Registruj se',
                            style: TextStyle(
                              color: Colors.white,
                              fontSize: 20
                            ),
                          ),
                        ),
                      ),
                    ),
                  ],
                  ),
                  ),
                  const SizedBox(height: 10),
                  Row(
                    children: [
                      const SizedBox(width:5),
                      const Text(
                        'Vec imate račun? ', 
                        style: TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)
                        ),
                      ),
                      const SizedBox(width: 20),
                      InkWell(
                        onTap: () => Navigator.pushNamed(context, '/login'),
                        child: const Text(
                          'Prijavi se ovdje',
                          style: TextStyle(
                            fontWeight: FontWeight.bold,
                            color: Colors.white,
                          ),
                        ),
                      ),
                    ],
                  ),
          ],
          ),
      ),
    ),
    ),
  );
  }
}