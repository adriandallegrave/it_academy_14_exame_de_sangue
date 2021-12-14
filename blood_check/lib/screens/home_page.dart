import 'package:blood_check/screens/home_patient.dart';
import 'package:blood_check/screens/patient.dart';
import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  const HomePage({ Key? key }) : super(key: key);

  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {

  void _goToPatientPage(){
    Navigator.push(context, MaterialPageRoute(builder: (BuildContext context) => const HomePatient()));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        color: Colors.white,
        child: Column(
          children: [
            Expanded(
              flex: 3,
              child: Container(
                color: Colors.blue.shade700,
              ),
            ),
            Expanded(
              flex: 2,
              child: Container(
                color: Colors.blue.shade200,
              ),
            ),
            Expanded(
              flex: 7,
              child: Container(
                padding: const EdgeInsets.all(28),
                width: double.maxFinite,
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Image.asset("assets/water-drop.png", height: 40,),
                    const SizedBox(height: 8),
                    const Text(
                      "Blood Check",
                      style: TextStyle(
                        color: Colors.lightBlue,
                        fontSize: 25,
                        fontWeight: FontWeight.w300
                      ),
                    )
                  ],
                )
              ),
            ),
            Expanded(
              flex: 2,
              child: Container(
                padding: const EdgeInsets.all(16),
                alignment: Alignment.centerRight,
                color: Colors.blue.shade700,
                child:  OutlinedButton(
                  onPressed: _goToPatientPage,
                  style: OutlinedButton.styleFrom(
                    side: const BorderSide(
                      color: Colors.white
                    )
                  ),
                  child: const Text(
                    "Get Started",
                    style: TextStyle(
                      color: Colors.white
                    ),
                  )
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}