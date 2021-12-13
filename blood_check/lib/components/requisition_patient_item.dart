import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/screens/requisition.dart';

class RequisitionPatientItem extends StatefulWidget {
  final String name;
  final String date; //Check about date formats in flutter.
  final int PatientId;
  final int DoctorId;

  const RequisitionPatientItem(
      this.name, this.date, this.PatientId, this.DoctorId);

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
        subtitle: Text(" ${widget.name} - ${widget.date} "),
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
