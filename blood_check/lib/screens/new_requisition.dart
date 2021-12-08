import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

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
          backgroundColor: Colors.blue,
          centerTitle: true,
          title: const Text('Blood Check',
              style: TextStyle(fontSize: 40, color: Colors.white)),
        ),
        body: Container(
            padding: const EdgeInsets.all(40),
            child: Wrap(children: <Widget>[
              Container(
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
                  )),
              Container(
                  child: Column(
                      // Requisicao
                      mainAxisSize: MainAxisSize.min,
                      children: const [
                    Text(
                      'Nova Requisição',
                      style: TextStyle(fontSize: 18),
                    ),
                    // Date Picker goes here
                  ])) // Container
            ]))); // Scaffold
  }
}
