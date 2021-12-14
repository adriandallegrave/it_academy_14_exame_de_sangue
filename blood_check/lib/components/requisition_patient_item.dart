// This is the item in a list of the exams of the requisition

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/screens/requisition.dart';

class RequisitionPatientItem extends StatefulWidget {
  final String exams; //Insert exams for each requisition
  final String date; //Check about date formats in flutter.

  const RequisitionPatientItem(this.exams, this.date);

  @override
  _RequisitionPatientItemState createState() => _RequisitionPatientItemState();
}

class _RequisitionPatientItemState extends State<RequisitionPatientItem> {
  @override
  Widget build(BuildContext context) {
    return Card(
      color: Colors.white,
      shape: const RoundedRectangleBorder(
        borderRadius: BorderRadius.all(Radius.circular(16)),
      ),
      child: ListTile(
        //title: Text(widget.name, style: TextStyle(color: kPrimaryColor)),
        subtitle: Text(
            " ${widget.date} - ${widget.exams} "), //Insert data from DB here
        onTap: () {
          Navigator.push(
            context,
            MaterialPageRoute(
                builder: (context) =>
                    const Requisition()), //Check how to pass data by parameter when clicking.
          );
        },
      ),
    );
  }
}
