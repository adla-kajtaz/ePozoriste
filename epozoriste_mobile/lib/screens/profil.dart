import 'package:epozoriste_mobile/widgets/widgets.dart';
import 'package:epozoriste_mobile/models/kupovina.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/kupovina_provider.dart';

class Profil extends StatefulWidget {
  const Profil({super.key});

  @override
  State<Profil> createState() => _ProfilState();
}

class _ProfilState extends State<Profil> {
  List<Kupovina> kupovine = [];
  KupovinaProvider? _kupovinaProvider;

  @override
  void initState() {
    super.initState();
    _kupovinaProvider = context.read<KupovinaProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _kupovinaProvider?.getByKorisnikId(1); // dodati id
    setState(() {
      kupovine = tempData!;
    });
  }

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
            padding: const EdgeInsets.all(16),
            child: Column(children: [
              if (kupovine.isNotEmpty)
                SizedBox(
                  height: 200,
                  width: double.infinity,
                  child: Historija(
                    kupovine: [...kupovine],
                  ),
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
                    try {
                      Navigator.pushNamed(context, '/detaljiProfil');
                    } catch (e) {
                      print(e.toString());
                    }
                  },
                  child: const Center(
                    child: Text(
                      'Postavke profila',
                      style: TextStyle(
                        color: Color.fromARGB(225, 86, 81, 81),
                        fontSize: 20,
                      ),
                    ),
                  ),
                ),
              ),
            ]),
          ),
        ),
      ),
    );
  }
}
