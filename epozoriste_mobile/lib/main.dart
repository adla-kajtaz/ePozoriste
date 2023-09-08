import 'package:epozoriste_mobile/providers/auth_provider.dart';
import 'package:epozoriste_mobile/providers/karta_provider.dart';
import 'package:epozoriste_mobile/providers/korisnik_provider.dart';
import 'package:epozoriste_mobile/providers/obavijest_provider.dart';
import 'package:epozoriste_mobile/providers/termin_provider.dart';
import 'package:epozoriste_mobile/screens/screens.dart';
import 'package:epozoriste_mobile/screens/sjedista.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

void main() {
  runApp(
    MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => TerminProvider()),
        ChangeNotifierProvider(create: (_) => ObavijestProvider()),
        ChangeNotifierProvider(create: (_) => KorisnikProvider()),
        ChangeNotifierProvider(create: (_) => KartaProvider()),
      ],
      child: const MyApp(),
    ),
  );
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'ePozoriste',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 57, 53, 53)),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        '/login': (context) => const Login(),
        '/register': (context) => const Register(),
        '/': (context) => const Navigacija(),
        '/detaljiPredstave': (context) => const DetaljiPredstave(),
        '/detaljiNovosti': (context) => const DetaljiNovosti(),
        '/detaljiProfil': (context) => const DetaljiProfila(),
        '/sjedista': (context) => const Sjedista(),
      },
      /*home: const MyHomePage(title: 'Flutter Demo Home Page'),*/
    );
  }
}
