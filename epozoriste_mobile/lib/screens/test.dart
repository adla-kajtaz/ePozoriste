import 'package:provider/provider.dart';
import '../models/karta.dart';
import 'package:flutter/material.dart';
import '../providers/karta_provider.dart';

class Test extends StatefulWidget {
  const Test({super.key});

  @override
  State<Test> createState() => _TestState();
}

class _TestState extends State<Test> {
  List<Karta> karte = [];
  KartaProvider? _kartaProvider;
  @override
  void initState() {
    super.initState();
    _kartaProvider = context.read<KartaProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _kartaProvider?.get();
    setState(() {
      karte = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 86, 81, 81),
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 57, 53, 53),
        title: const Text(
          'ePozorište',
          style: TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
        ),
      ),
      body: GridView.builder(
        gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
          crossAxisCount: 4, // Number of seats per row
        ),
        itemCount: karte.length,
        itemBuilder: (context, index) {
          final seat = karte[index];
          final seatColor = seat.aktivna ? Colors.green : Colors.red;

          return Container(
            margin: const EdgeInsets.all(8.0),
            color: seatColor,
            child: Center(
              child: Text(seat.sjediste),
            ),
          );
        },
      ),
    );
  }
}
