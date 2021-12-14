import 'package:blood_check/screens/home_page.dart';
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
        '/': (context) => const HomePage(),
        '/patient': (context) => const Patient(),
        '/requisition': (context) => const Requisition(),
        '/newRequisition': (context) => const NewRequisition(),
      },
      debugShowCheckedModeBanner: false,
    ),
  );
}