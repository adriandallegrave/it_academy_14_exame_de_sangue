// This component is used for entering new patients. There are fields to input the patient data and a button below to save the new patient.

import 'package:blood_check/models/patient_model.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/constants.dart';

class NewPatient extends StatefulWidget {
  const NewPatient({Key? key}) : super(key: key);

  @override
  _NewPatientState createState() => _NewPatientState();
}

class _NewPatientState extends State<NewPatient> {
  final TextEditingController _nameController = TextEditingController();
  final TextEditingController _cpfController = TextEditingController();
  final TextEditingController _phoneController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Form(
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: <Widget>[
          Container(
            margin: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
            padding: const EdgeInsets.all(8),
            decoration: BoxDecoration(
              color: kSecondColor,
              border: Border.all(
                color: kSecondColor,
              ),
              borderRadius: const BorderRadius.all(Radius.circular(16)),
            ),
            child: Column(
              children: [
                Container(
                  margin: const EdgeInsets.fromLTRB(8, 8, 8, 0),
                  padding:
                      const EdgeInsets.symmetric(horizontal: 25, vertical: 5),
                  decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(10),
                    border: Border.all(
                      color: Colors.white,
                    ),
                  ),
                  child: TextFormField(
                    controller: _nameController,
                    decoration: const InputDecoration(
                        border: InputBorder.none,
                        icon: Icon(Icons.person),
                        hintText: 'Nome',
                        labelStyle: TextStyle(color: Colors.grey)),
                    //keyboardType: TextInputType.datetime,
                  ),
                ),
                Container(
                  margin: const EdgeInsets.fromLTRB(8, 8, 8, 8),
                  padding:
                      const EdgeInsets.symmetric(horizontal: 25, vertical: 5),
                  decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(10),
                    border: Border.all(
                      color: Colors.white,
                    ),
                  ),
                  child: TextFormField(
                    controller: _cpfController,
                    decoration: const InputDecoration(
                      border: InputBorder.none,
                      icon: Icon(Icons.document_scanner_outlined),
                      hintText: 'CPF',
                    ),
                    keyboardType: TextInputType.number,
                  ),
                ),
                Container(
                  margin: const EdgeInsets.fromLTRB(8, 8, 8, 8),
                  padding:
                      const EdgeInsets.symmetric(horizontal: 25, vertical: 5),
                  decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(10),
                    border: Border.all(
                      color: Colors.white,
                    ),
                  ),
                  child: TextFormField(
                    controller: _phoneController,
                    decoration: const InputDecoration(
                      border: InputBorder.none,
                      icon: Icon(Icons.phone_callback_outlined),
                      hintText: 'Telefone',
                    ),
                    keyboardType: TextInputType.number,
                  ),
                ),
                // Save Button
                OutlinedButton(
                  /*
                  style: const ButtonStyle styleFrom({
                    foregroundColor: Colors.white;
                  }),
                  */
                  onPressed: () {
                    // Save the new pacient
                    debugPrint('Received click');

                    // Create the patient model and extract the info from the TextFields
                    Patient_Model newpatient = Patient_Model(
                        name: _nameController.text,
                        cpf: _cpfController.text,
                        phone: _phoneController.text);

                    debugPrint(newpatient.name);
                    debugPrint(newpatient.cpf);
                    debugPrint(newpatient.phone);

                    newpatient.save();
                  },
                  //enabled:
                  child: const Text('Salvar Paciente'),
                )
              ],
            ),
          ),
        ],
      ),
    );
  }

  Widget myWidget() {
    return Scaffold(
      floatingActionButton: FloatingActionButton(
        onPressed: () {},
        backgroundColor: kPrimaryColor,
        child: const Icon(Icons.add_outlined),
      ),
    );
  }
}
