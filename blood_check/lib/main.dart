import 'package:blood_check/screens/home_patient.dart';
import 'package:blood_check/screens/new_patient.dart';
import 'package:blood_check/screens/new_requisition.dart';
import 'package:blood_check/screens/patient.dart';
import 'package:blood_check/screens/requisition.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(
    MaterialApp(
      title: 'Rotas',
      initialRoute: '/',
      routes: {
        '/': (context) => const Patient(),
        '/second': (context) => const Requisition(),
        '/third': (context) => const NewRequisition(),
      },
      debugShowCheckedModeBanner: false,
    ),
  );
}
