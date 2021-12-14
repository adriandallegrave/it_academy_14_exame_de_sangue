// This component represents the list of patients already on the database.

import 'package:blood_check/components/patient_list_item.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/constants.dart';
import 'package:blood_check/providers/patient_provider.dart';
import 'package:blood_check/models/patient_models.dart';

class PatientList extends StatefulWidget {
  const PatientList({Key? key}) : super(key: key);

  @override
  _PatientListState createState() => _PatientListState();
}

class _PatientListState extends State<PatientList> {

  List pacientes = await ApiService.getPatients(); // this should return the list of patients???

  @override
  Future<Widget> build(BuildContext context) async {
    return Container(
      margin: const EdgeInsets.only(top: 16, left: 16, right: 16, bottom: 0),
      decoration: const BoxDecoration(
        color: kSecondColor,
        borderRadius: BorderRadius.only(
          topLeft: Radius.circular(16),
          topRight: Radius.circular(16),
        ),
      ),
      child: Expanded(
        child: ListView(
          padding: const EdgeInsets.only(left: 8, right: 8, top: 8, bottom: 0),
          children: const <Widget>[
            // Check about date formats in flutter.
            PatientListItem("Debora"),
            // Insert data from DB here

            //PatientListItem()
          ],
        ),
      ),
    );
  }
}
