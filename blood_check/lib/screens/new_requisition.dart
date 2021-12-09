import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'package:blood_check/components/patient_data.dart';
import 'package:blood_check/components/requisition_data.dart';

class NewRequisition extends StatefulWidget {
  const NewRequisition({Key? key}) : super(key: key);

  @override
  _NewRequisitionState createState() => _NewRequisitionState();
}

class _NewRequisitionState extends State<NewRequisition> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          backgroundColor: Colors.blue[600],
          centerTitle: true,
          title: const Text('Blood Check',
              style: TextStyle(fontSize: 24, color: Colors.white)),
        ),
        body: Container(
            //padding: const EdgeInsets.all(40),
            child: Wrap(spacing: 8.0, runSpacing: 4.0, children: <Widget>[
          PatientData(),
          RequisitionData(),
        ]))); // Scaffold
  }
}
