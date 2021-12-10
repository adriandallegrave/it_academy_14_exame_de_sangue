import 'package:blood_check/components/patient_data.dart';
import 'package:blood_check/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'new_requisition.dart';

class Patient extends StatefulWidget {
  const Patient({Key? key}) : super(key: key);

  @override
  _PatientState createState() => _PatientState();
}

class _PatientState extends State<Patient> {
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
        title: const Text('Blood Check - patient',
            style: TextStyle(fontSize: 24, color: Colors.white)),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () {},
        ),
      ),
      body: Wrap(
        children: <Widget>[
          Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: <Widget>[
              const PatientData(),
              Container(
                margin: const EdgeInsets.symmetric(horizontal: 16),
                padding: const EdgeInsets.symmetric(horizontal: 8),
                decoration: const BoxDecoration(
                    color: kSecondColor,
                    borderRadius: BorderRadius.only(
                      topLeft: Radius.circular(16),
                      topRight: Radius.circular(16),
                    )),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children:
                      // ignore: prefer_const_literals_to_create_immutables
                      [
                    const Padding(
                      padding: EdgeInsets.all(8.0),
                      child: Text(
                        "Requisições Anteriores",
                        textAlign: TextAlign.start,
                        style: TextStyle(
                            color: Colors.white,
                            fontWeight: FontWeight.w600,
                            fontSize: 20),
                      ),
                    )
                  ],
                ),
              ),
            ],
          )
        ],

        // This component is not working!.
        /*
          Expanded(
            child: ListView(children: const <Widget>[
              Text('list Requisitions'),
            ]),
          ),
        */
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const NewRequisition()),
          );
        },
        backgroundColor: kPrimaryColor,
        child: const Icon(Icons.add_outlined),
      ),
    );
  }
}
