import 'package:blood_check/components/exam_data.dart';
import 'package:blood_check/constants.dart';
import 'package:blood_check/screens/requisition.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'package:blood_check/providers/patient_provider.dart';

import 'package:blood_check/components/patient_data.dart';
import 'package:blood_check/components/requisition_data.dart';

class Teste extends StatefulWidget {
  const Teste({Key? key}) : super(key: key);

  @override
  _TesteState createState() => _TesteState();
}

class _TesteState extends State<Teste> {
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
                MaterialPageRoute(builder: (context) => const Requisition()),
              );
            },
          ),
        ),
        body: FutureBuilder(
          future: ApiService.getPatients(),
          builder: (context, snapshot) {
            if (snapshot.connectionState == ConnectionState.done) {
              return ListView.separated(
                separatorBuilder: (context, index) {
                  return const Divider(
                    height: 2,
                    color: Colors.black,
                  );
                },
                itemBuilder: (context, index) {
                  return ListTile(title: Text(snapshot.data));
                },
                itemCount: patients == Null ? 0 : 1,
              );
            }
            return Center(
              child: CircularProgressIndicator(),
            );
          },
        ));
  }
}
