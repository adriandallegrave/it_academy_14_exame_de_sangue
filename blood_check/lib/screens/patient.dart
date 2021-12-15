import 'package:blood_check/components/patient_data.dart';
import 'package:blood_check/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'home_patient.dart';
import 'new_requisition.dart';
import 'package:blood_check/components/requisition_patient_data.dart';

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
      // This is the main area of the screen. It contains the PatientData component (name, cpf...) and the new requesition button.
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: const [
          PatientData(),
          Padding(
            padding: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
          ),
          RequisitionPatient(),
        ],
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const NewRequisition()),
          );
        },
        backgroundColor: kPrimaryColor,
        child: const Icon(Icons.add_outlined),
      ),
    );
  }
}
