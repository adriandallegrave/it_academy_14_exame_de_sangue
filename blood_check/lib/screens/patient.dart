import 'package:blood_check/components/patient_data.dart';
import 'package:blood_check/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class Patient extends StatefulWidget {
  const Patient({Key? key}) : super(key: key);

  @override
  _PatientState createState() => _PatientState();
}

class _PatientState extends State<Patient> {
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
          title: const Text('Blood Check',
              style: TextStyle(fontSize: 24, color: Colors.white)),
        ),
        body: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: const <Widget>[PatientData()]));
  }
}
