// This component presents the requisitions for each patient.

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/constants.dart';
import 'package:blood_check/components/requisition_patient_item.dart';

class RequisitionPatient extends StatefulWidget {
  const RequisitionPatient({Key? key}) : super(key: key);

  @override
  _RequisitionPatientState createState() => _RequisitionPatientState();
}

class _RequisitionPatientState extends State<RequisitionPatient> {
  @override
  Widget build(BuildContext context) {
    return Expanded(
      child: Container(
        margin: const EdgeInsets.symmetric(horizontal: 16),
        padding: const EdgeInsets.symmetric(horizontal: 8),
        decoration: const BoxDecoration(
          color: kSecondColor,
          borderRadius: BorderRadius.only(
            topLeft: Radius.circular(16),
            topRight: Radius.circular(16),
          ),
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            const Padding(
              padding: EdgeInsets.all(8.0),
              child: Text("Requisições",
                  textAlign: TextAlign.start,
                  style: TextStyle(
                      color: Colors.white,
                      fontWeight: FontWeight.w600,
                      fontSize: 20)),
            ),
            Expanded(
              child: ListView(
                // This is the list of Requisitions in the patient details screen.
                children: const <Widget>[
                  // Insert data from DB here
                  // Check about date formats in flutter.
                  RequisitionPatientItem(
                      "Exames da requisição 1", "03/12/2021"),
                  RequisitionPatientItem(
                      "Exames da requisição 2", "05/12/2021"),
                  RequisitionPatientItem(
                      "Exames da requisição 3", "01/12/2021"),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
