import 'package:blood_check/constants.dart';
import 'package:blood_check/screens/patient.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'home_patient.dart';

class NewPatient extends StatefulWidget {
  const NewPatient({Key? key}) : super(key: key);

  @override
  _PatientState createState() => _PatientState();
}

class _PatientState extends State<NewPatient> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        shape: const RoundedRectangleBorder(
          borderRadius: BorderRadius.vertical(
            bottom: Radius.circular(8),
          ),
        ),
        backgroundColor: kPrimaryColor,
        centerTitle: true,
        title: const Text('Blood Check - new patient',
            style: TextStyle(fontSize: 24, color: Colors.white)),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () {
            Navigator.push(
              context,
              MaterialPageRoute(builder: (context) => const HomePatient()),
            );
          },
        ),
      ),
      body: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: <Widget>[Container()]),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const HomePatient()),
          );
        },
        backgroundColor: kPrimaryColor,
        child: const Icon(Icons.add_outlined),
      ),
    );
  }
}
