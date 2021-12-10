import 'package:blood_check/screens/new_requisition.dart';
import 'package:blood_check/screens/patient.dart';
import 'package:blood_check/screens/requisition.dart';
import 'package:blood_check/screens/teste.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(MaterialApp(
    title: 'Rotas',
    initialRoute: '/',
    routes: {
      //'/': (context) => const NewRequisition(),
      '/': (context) => const Teste(),
      '/second': (context) => const Requisition(),
      '/third': (context) => const Patient(),
    },
    debugShowCheckedModeBanner: false,
  ));
}
