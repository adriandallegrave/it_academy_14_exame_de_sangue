import 'package:blood_check/components/exam_data.dart';
import 'package:blood_check/constants.dart';
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
      body: Column(
        children: const [
          PatientData(),
          RequisitionData(),
          ExamData(),
        ]
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
                          "Prazo de Entrega Final:  3 dias úteis",
                          style: TextStyle(
                            fontSize: 16,
                            color: Colors.white
                          )
                        )
                      ]
                    ),
                    Row(
                      children: const [
                        Text(
                          "Total: R\$ 33,00",
                          style: TextStyle(
                            fontSize: 16,
                            color: Colors.white
                          )
                        )
                      ],
                    ),
                  ]
                ),
              ),
              IconButton(
                iconSize: 45,
                onPressed: (){}, 
                icon: const Icon(
                Icons.check_circle_outline_rounded,
                color: Colors.white,
              ),),
              const SizedBox(width: 16)
            ],
          ),
        ),
      )
    );  
  }
}
