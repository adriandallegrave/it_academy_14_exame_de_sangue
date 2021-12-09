import 'package:blood_check/constants.dart';
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
        margin: const EdgeInsets.all(8),
        padding: const EdgeInsets.all(8),
        decoration: BoxDecoration(
          color: Colors.transparent,
          border: Border.all(
            color: Colors.transparent,
          ),
          borderRadius: BorderRadius.all(Radius.circular(6)),
        ),
        child: Column(mainAxisSize: MainAxisSize.min, children: [
          Row(children: [
            RichText(
              text: TextSpan(
                  text: 'Débora Sanchéz', //Insert name from DB here
                  style: TextStyle(
                      color: kPrimaryColor,
                      fontSize: 24,
                      fontWeight: FontWeight.bold)),
            )
          ]),
          Row(children: [
            RichText(
                text: TextSpan(children: <TextSpan>[
              TextSpan(
                  text: 'CPF: ',
                  style: TextStyle(
                      color: kPrimaryColor,
                      fontSize: 16,
                      fontWeight: FontWeight.bold)),
              TextSpan(
                  text: '811.886.999-20',
                  style: TextStyle(
                      color: kPrimaryColor,
                      fontSize: 16)), //Insert 'CPF' from DB
            ]))
          ]),
          Row(children: [
            RichText(
                text: TextSpan(children: <TextSpan>[
              TextSpan(
                  text: 'Telefone: ',
                  style: TextStyle(
                      color: kPrimaryColor, fontWeight: FontWeight.bold)),
              TextSpan(
                  text: '51 98169-3449',
                  style: TextStyle(
                      color: kPrimaryColor,
                      fontSize: 12)), //Insert phone number from DB
            ]))
          ]),
        ])); // Scaffold
  }
}
