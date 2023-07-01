import 'package:epozoriste_mobile/widgets/performanceList.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../models/models.dart';
import '../providers/termin_provider.dart';


class Home extends StatefulWidget{
  const Home({super.key});
  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home>{
  List<Termin>termini =[];
  TerminProvider? _terminProvider;
  final List<Tab>myTabs=<Tab>[
    const Tab(text: 'Trenutno se prikazuje'),
    const Tab(text: 'Preporučeno')
  ];

  @override
  void initState(){
    super.initState();
    //_terminProvider = context.read<TerminProvider>();
    //loadData();
  }

  Future loadData() async {
    var tempData = await _terminProvider?.get();
    setState(() {
      termini = tempData!;
    });
  }



  @override
  Widget build(BuildContext context){
    return DefaultTabController(
      length: 2, 
      child: SafeArea(
        child: Scaffold(
          backgroundColor: const Color.fromARGB(255, 86, 81, 81),
          appBar: AppBar(
            automaticallyImplyLeading: false,
             backgroundColor: const Color.fromARGB(255, 57, 53, 53),
            title: const Text(
              'ePozorište', 
              style: TextStyle(
                color: Color.fromARGB(225, 195, 178, 178)
                ),
                ),
            bottom: TabBar(
              labelColor: const Color.fromARGB(225, 195, 178, 178),
              unselectedLabelColor: Colors.white,
              indicatorColor: const Color.fromARGB(255, 116, 108, 108),
              tabs: myTabs
              ),
          ),
           body:  Padding(
            padding: const EdgeInsets.all(16),
             child:TabBarView(
            children: [
              //PerformanceList(termini: termini),

              ListView.builder(
                itemCount: 105,
                itemBuilder: (context, index) =>  Text("Test $index"),
                
              ),
              const Center(
                child: Text('sadrzaj 2'),
              ),
            ],
           ),
           ),
        ),
        ),
      );
  }
}