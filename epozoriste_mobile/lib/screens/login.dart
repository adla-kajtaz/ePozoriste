import 'package:epozoriste_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/auth_provider.dart';

class Login extends StatefulWidget {
  static const routeName = '/login';

  const Login({super.key});

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  final formKey = GlobalKey<FormState>();
  String? korisnickoIme;
  String? lozinka;
  AuthProvider? _authProvider;

  @override
  void initState() {
    super.initState();
    _authProvider = context.read<AuthProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 86, 81, 81),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: SingleChildScrollView(
          child: Column(
            children: [
              const SizedBox(
                height: 100,
              ),
              const Text(
                'ePozoriste',
                style: TextStyle(
                  fontSize: 50,
                  fontWeight: FontWeight.bold,
                  color: Color.fromARGB(225, 195, 178, 178),
                ),
              ),
              const SizedBox(
                height: 80,
              ),
              Form(
                key: formKey,
                child: Column(
                  children: [
                    TextFormField(
                      onSaved: (newValue) => korisnickoIme = newValue,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "Ovo polje je obavezno";
                        }
                      },
                      style: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)),
                      decoration: InputDecoration(
                        labelText: 'Korisničko ime',
                        hintText: 'Korisničko ime',
                        labelStyle: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)),
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15)),
                      ),
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    TextFormField(
                      onSaved: (newValue) => lozinka = newValue,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "Ovo polje je obavezno";
                        }
                      },
                      obscureText: true,
                      autocorrect: false,
                      style: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)),
                      decoration: InputDecoration(
                        labelText: 'Lozinka',
                        labelStyle: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)),
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15)),
                        hintText: '********',
                      ),
                    ),
                  ],
                ),
              ),
              const SizedBox(
                height: 20,
              ),
              Container(
                height: 50,
                width: double.infinity,
                decoration: BoxDecoration(
                  color: const Color.fromARGB(225, 217, 217, 217),
                  borderRadius: BorderRadius.circular(10),
                ),
                child: InkWell(
                  onTap: () async {
                    if (formKey.currentState!.validate()) {
                      formKey.currentState!.save();
                      Map user = {
                        'korisnickoIme': korisnickoIme,
                        'lozinka': lozinka
                      };
                      try {
                        var data = await _authProvider!.login(user);
                        if (context.mounted) {
                          _authProvider!
                              .setParameters(data!.korisnikId!.toInt());
                          Navigator.popAndPushNamed(
                              context, Navigacija.routeName);
                        }
                      } on Exception catch (error) {
                        print(error.toString());
                        if (error.toString().contains("Bad request")) {
                          formKey.currentState!.validate();
                        }
                      }
                    }
                  },
                  child: const Center(
                    child: Text(
                      'Prijavi se',
                      style: TextStyle(
                        color: Color.fromARGB(225, 86, 81, 81),
                        fontSize: 20,
                      ),
                    ),
                  ),
                ),
              ),
              const SizedBox(height: 20),
              Row(
                children: [
                  const SizedBox(width: 5),
                  const Text(
                    'Nemate račun?',
                    style: TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
                  ),
                  const SizedBox(width: 20),
                  InkWell(
                    onTap: () =>
                        Navigator.pushNamed(context, Register.routeName),
                    child: const Text(
                      'Registruj se ovdje.',
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
    );
  }
}
