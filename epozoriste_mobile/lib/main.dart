import 'package:epozoriste_mobile/screens/login.dart';
import 'package:epozoriste_mobile/screens/register.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});


  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'ePozoriste',
      theme: ThemeData(
        
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        '/login': (context) => Login(),
        '/register': (context) => Register(),
      },
      /*home: const MyHomePage(title: 'Flutter Demo Home Page'),*/
    );
  }
}




  
