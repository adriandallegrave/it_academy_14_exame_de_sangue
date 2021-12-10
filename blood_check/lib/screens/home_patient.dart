import 'package:blood_check/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'new_patient.dart';

class HomePatient extends StatefulWidget {
  const HomePatient({Key? key}) : super(key: key);

  @override
  _PatientState createState() => _PatientState();
}

class _PatientState extends State<HomePatient> {
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
        title: const Text('Blood Check - home patient',
            style: TextStyle(fontSize: 24, color: Colors.white)),
      ),
      body: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: <Widget>[Container()]),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const NewPatient()),
          );
        },
        backgroundColor: kPrimaryColor,
        child: const Icon(Icons.add_outlined),
      ),
    );
  }
}
