// This is the requisition screen. It contains the Patient Data (name, cpf...), Requisition data and Exam data - relative to this specific requisition;

import 'package:blood_check/components/exam_data.dart';
import 'package:blood_check/constants.dart';
import 'package:blood_check/screens/patient.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'package:blood_check/components/patient_data.dart';
import 'package:blood_check/components/requisition_data.dart';

class Requisition extends StatefulWidget {
  const Requisition({Key? key}) : super(key: key);

  @override
  _RequisitionState createState() => _RequisitionState();
}

class _RequisitionState extends State<Requisition> {
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
              MaterialPageRoute(builder: (context) => const Patient()),
            );
          },
        ),
      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          const PatientData(),
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
            child: Row(
              children: [
                const Text(
                  'Requisição',
                  textAlign: TextAlign.left,
                  style: TextStyle(
                      fontSize: 20,
                      color: kPrimaryColor,
                      fontWeight: FontWeight.w600),
                ),
                IconButton(
                  iconSize: 20,
                  onPressed: () {
                    showAlertDialog(context);
                    //const AlertDialog(title: Text('Excluído'));
                    // Still pending.
                  },
                  icon: const Icon(
                    Icons.delete_outlined,
                    color: kPrimaryColor,
                  ),
                ),
              ],
            ),
          ),
          const RequisitionData(),
          const ExamData(),
        ],
      ),
      bottomNavigationBar: BottomAppBar(
        color: kPrimaryColor,
        child: SizedBox(
          height: 70,
          child: Row(
            mainAxisAlignment: MainAxisAlignment.start,
            children: [
              const SizedBox(width: 16),
              Expanded(
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: <Widget>[
                    Row(
                      children: const [
                        Text(
                            "Prazo de Entrega Final:  3 dias úteis", //Insert data from DB here
                            style: TextStyle(fontSize: 16, color: Colors.white))
                      ],
                    ),
                    Row(
                      children: const [
                        Text("Total: R\$ 33,00", //Insert data from DB here
                            style: TextStyle(fontSize: 16, color: Colors.white))
                      ],
                    ),
                  ],
                ),
              ),
              IconButton(
                iconSize: 45,
                onPressed: () {
                  Navigator.push(
                    context,
                    MaterialPageRoute(builder: (context) => const Patient()),
                  );
                },
                icon: const Icon(
                  Icons.check_circle_outline_rounded,
                  color: Colors.white,
                ),
              ),
              const SizedBox(width: 16)
            ],
          ),
        ),
      ),
    );
  }
}

showAlertDialog(BuildContext context) {
  Widget okButton = TextButton(
    child: Text("ok"),
    onPressed: () {
      Navigator.push(
        context,
        MaterialPageRoute(builder: (context) => const Patient()),
      );
    },
  );

  AlertDialog alert = AlertDialog(
    title: Text('Excluído'),
    actions: [
      okButton,
    ],
  );

  showDialog(
    context: context,
    builder: (BuildContext context) {
      return alert;
    },
  );
}
