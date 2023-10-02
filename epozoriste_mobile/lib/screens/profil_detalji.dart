import 'package:epozoriste_mobile/models/korisnik.dart';
import 'package:epozoriste_mobile/providers/korisnik_provider.dart';
import 'package:epozoriste_mobile/screens/login.dart';
import '../providers/auth_provider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class DetaljiProfila extends StatefulWidget {
  static const routeName = '/detaljiProfil';

  const DetaljiProfila({super.key});

  @override
  State<DetaljiProfila> createState() => _DetaljiProfilaState();
}

class _DetaljiProfilaState extends State<DetaljiProfila> {
  final formKey = GlobalKey<FormState>();
  AuthProvider? _authProvider;
  KorisnikProvider? _korisnikProvider;
  Korisnik? korisnik;

  @override
  void initState() {
    super.initState();
    _korisnikProvider = context.read<KorisnikProvider>();
    _authProvider = context.read<AuthProvider>();
    loadUser();
  }

  void loadUser() async {
    var data = await _korisnikProvider!
        .getUser(_authProvider!.getLoggedUserId()); // dodati id
    setState(() {
      korisnik = data;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (korisnik == null) {
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
            'Profil',
            style: TextStyle(color: Colors.white),
          ),
        ),
        body: const Center(
          child: Text(
            'Učitavanje ...',
            style: TextStyle(
              color: Color.fromARGB(225, 195, 178, 178),
            ),
          ),
        ),
      );
    }
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
          'Profil',
          style: TextStyle(color: Colors.white),
        ),
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(20),
            child: Form(
              key: formKey,
              child: Column(children: [
                const Text(
                  'Korisničko ime:',
                  style: TextStyle(
                    color: Color.fromARGB(225, 195, 178, 178),
                  ),
                ),
                const SizedBox(height: 5),
                TextFormField(
                  onSaved: (newValue) => korisnik!.korisnickoIme = newValue!,
                  initialValue: korisnik!.korisnickoIme,
                  style: const TextStyle(
                    color: Color.fromARGB(225, 195, 178, 178),
                  ),
                  decoration: InputDecoration(
                    border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(15),
                    ),
                    labelStyle: const TextStyle(
                      color: Color.fromARGB(225, 195, 178, 178),
                    ),
                  ),
                  validator: (newValue) {
                    if (newValue!.isEmpty) {
                      return 'Ovo polje je obavezno!';
                    }
                    return null;
                  },
                ),
                const SizedBox(height: 10),
                const Text(
                  'Email:',
                  style: TextStyle(
                    color: Color.fromARGB(225, 195, 178, 178),
                  ),
                ),
                const SizedBox(height: 5),
                TextFormField(
                  onSaved: (newValue) => korisnik!.email = newValue!,
                  initialValue: korisnik!.email,
                  style: const TextStyle(
                      color: Color.fromARGB(225, 195, 178, 178)),
                  decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15)),
                    labelStyle: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)),
                  ),
                ),
                const SizedBox(height: 10),
                const Text(
                  'Ime:',
                  style: TextStyle(
                    color: Color.fromARGB(225, 195, 178, 178),
                  ),
                ),
                const SizedBox(height: 5),
                TextFormField(
                  onSaved: (newValue) => korisnik!.ime = newValue!,
                  initialValue: korisnik!.ime,
                  style: const TextStyle(
                      color: Color.fromARGB(225, 195, 178, 178)),
                  decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15)),
                    labelStyle: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)),
                  ),
                  validator: (newValue) {
                    if (newValue!.isEmpty) {
                      return 'Ovo polje je obavezno!';
                    }
                    return null;
                  },
                ),
                const Text(
                  'Prezime:',
                  style: TextStyle(
                    color: Color.fromARGB(225, 195, 178, 178),
                  ),
                ),
                const SizedBox(height: 5),
                const SizedBox(height: 10),
                TextFormField(
                  onSaved: (newValue) => korisnik!.prezime = newValue!,
                  initialValue: korisnik!.prezime,
                  style: const TextStyle(
                      color: Color.fromARGB(225, 195, 178, 178)),
                  decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15)),
                    labelStyle: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)),
                  ),
                  validator: (newValue) {
                    if (newValue!.isEmpty) {
                      return 'Ovo polje je obavezno!';
                    }
                    return null;
                  },
                ),
                const SizedBox(height: 10),
                const Text(
                  'Broj telefona:',
                  style: TextStyle(
                    color: Color.fromARGB(225, 195, 178, 178),
                  ),
                ),
                const SizedBox(height: 5),
                TextFormField(
                  onSaved: (newValue) => korisnik!.brTelefona = newValue!,
                  initialValue: korisnik!.brTelefona,
                  style: const TextStyle(
                      color: Color.fromARGB(225, 195, 178, 178)),
                  decoration: InputDecoration(
                    border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(15)),
                    labelStyle: const TextStyle(
                        color: Color.fromARGB(225, 195, 178, 178)),
                  ),
                  validator: (newValue) {
                    if (newValue!.isEmpty) {
                      return 'Ovo polje je obavezno!';
                    }
                    return null;
                  },
                ),
                const SizedBox(height: 10),
                InkWell(
                  onTap: () async {
                    if (formKey.currentState!.validate()) {
                      formKey.currentState!.save();
                      Map<String, dynamic> data = {
                        "ime": korisnik!.ime,
                        "prezime": korisnik!.prezime,
                        "korisnickoIme": korisnik!.korisnickoIme,
                        "email": korisnik!.email,
                        "brTelefona": korisnik!.brTelefona,
                      };
                      print(data);
                      try {
                        await _korisnikProvider!
                            .updateProfile(korisnik!.korisnikId, data);
                      } on Exception catch (err) {
                        print(err.toString());
                        formKey.currentState!.validate();
                      }
                    }
                  },
                  child: Container(
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                      color: const Color.fromARGB(225, 217, 217, 217),
                    ),
                    height: 50,
                    child: const Center(
                      child: Text(
                        'Sačuvaj promjene',
                        style: TextStyle(
                            color: Color.fromARGB(225, 86, 81, 81),
                            fontSize: 20),
                      ),
                    ),
                  ),
                ),
                const SizedBox(height: 10),
                InkWell(
                  onTap: () async {
                    if (formKey.currentState!.validate()) {
                      formKey.currentState!.save();
                    }
                    try {
                      Navigator.pushNamed(context, Login.routeName);
                    } on Exception catch (err) {
                      print(err.toString());
                      formKey.currentState!.validate();
                    }
                  },
                  child: Container(
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(10),
                      color: const Color.fromARGB(225, 217, 217, 217),
                    ),
                    height: 50,
                    child: const Center(
                      child: Text(
                        'Odjavi se',
                        style: TextStyle(
                            color: Color.fromARGB(225, 86, 81, 81),
                            fontSize: 20),
                      ),
                    ),
                  ),
                ),
              ]),
            ),
          ),
        ),
      ),
    );
  }
}
