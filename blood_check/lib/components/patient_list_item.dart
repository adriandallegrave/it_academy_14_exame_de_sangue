// This component is the item (pacient) in the patients list.

import 'package:blood_check/screens/patient.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'package:blood_check/providers/patient_provider.dart';

class PatientListItem extends StatefulWidget {
  final String name;

  const PatientListItem(this.name);

  @override
  _PatientListItemState createState() => _PatientListItemState();
}

class _PatientListItemState extends State<PatientListItem> {
  @override
  Widget build(BuildContext context) {
    return Card(
      color: Colors.white,
      shape: const RoundedRectangleBorder(
        borderRadius: BorderRadius.all(Radius.circular(16)),
      ),
      child: ListTile(
        subtitle: Text(" ${widget.name}"),
        onTap: () {
          Navigator.push(
            context,
            MaterialPageRoute(
                builder: (context) =>
                    const Patient()), //Check how to pass data by parameter when clicking.
          );
        },
      ),
    );
  }
}
