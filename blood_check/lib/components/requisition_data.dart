import 'package:blood_check/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class RequisitionData extends StatefulWidget {
  const RequisitionData({Key? key}) : super(key: key);

  @override
  _RequisitionDataState createState() => _RequisitionDataState();
}

class _RequisitionDataState extends State<RequisitionData> {
  @override
  Widget build(BuildContext context) {
    return Form(
      child: Column(
        children: <Widget>[
          Text(
            'Nova Requisição',
            textAlign: TextAlign.left,
            style: TextStyle(
                fontSize: 24,
                color: kPrimaryColor,
                fontWeight: FontWeight.bold),
          ),
          Container(
            margin: EdgeInsets.all(8),
            padding: const EdgeInsets.all(8),
            decoration: BoxDecoration(
              color: kSecondColor,
              border: Border.all(
                color: kSecondColor,
              ),
              borderRadius: BorderRadius.all(Radius.circular(6)),
            ),
            child: Column(
              //padding: const EdgeInsets.fromLTRB(32.0, 8.0, 32.0, 0.0),
              children: [
                Container(
                  margin: EdgeInsets.fromLTRB(8, 8, 8, 0),
                  padding: EdgeInsets.symmetric(horizontal: 25, vertical: 5),
                  decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(10),
                    border: Border.all(
                      color: Colors.white,
                    ),
                  ),
                  child: TextFormField(
                    decoration: InputDecoration(
                        border: InputBorder.none,
                        icon: Icon(Icons.date_range),
                        hintText: 'dd/mm/yyyy',
                        labelStyle: TextStyle(color: Colors.grey)),
                    keyboardType: TextInputType.datetime,
                  ),
                ),
                Container(
                  margin: EdgeInsets.fromLTRB(8, 8, 8, 8),
                  padding: EdgeInsets.symmetric(horizontal: 25, vertical: 5),
                  decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(10),
                    border: Border.all(
                      color: Colors.white,
                    ),
                  ),
                  child: TextFormField(
                    decoration: InputDecoration(
                      border: InputBorder.none,
                      icon: Icon(Icons.search),
                      hintText: 'CRM do médico',
                    ),
                    keyboardType: TextInputType.number,
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
