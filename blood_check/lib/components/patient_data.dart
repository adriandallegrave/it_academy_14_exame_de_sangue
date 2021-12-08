import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class PatientData extends StatefulWidget {
  const PatientData({Key? key}) : super(key: key);

  @override
  _PatientDataState createState() => _PatientDataState();
}

class _PatientDataState extends State<PatientData> {
  @override
  Widget build(BuildContext context) {
    return Container(
                  //Container de informações do paciente
                  margin: EdgeInsets.all(16),
                  padding: EdgeInsets.all(16),
                  decoration: BoxDecoration(
                    color: Colors.blue,
                    border: Border.all(),
                    borderRadius: BorderRadius.all(Radius.circular(3)),
                  ),
                  child: Column(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      Row(children: [
                        Padding(
                          padding: EdgeInsets.only(right: 8),
                        ),
                        Text('Nome'),
                      ]),
                      Row(children: [
                        Padding(
                          padding: EdgeInsets.only(right: 8),
                        ),
                        Text('CPF'),
                      ]),
                      Row(children: [
                        Padding(
                          padding: EdgeInsets.only(right: 8),
                        ),
                        Text('Telefone'),
                      ]),
                    ],
                  )); // Scaffold
  }
}
