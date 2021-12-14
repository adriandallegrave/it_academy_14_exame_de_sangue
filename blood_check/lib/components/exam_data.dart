// This component presents the checkbox list in the NewRequisition screen.

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/constants.dart';
import 'package:blood_check/components/exam_data_item.dart';

class ExamData extends StatefulWidget {
  const ExamData({Key? key}) : super(key: key);

  @override
  _ExamDataState createState() => _ExamDataState();
}

class _ExamDataState extends State<ExamData> {
  var selectedList = [];
  final _checked = false;

  @override
  Widget build(BuildContext context) {
    return Expanded(
      child: Container(
        margin: const EdgeInsets.symmetric(horizontal: 16),
        padding: const EdgeInsets.symmetric(horizontal: 8),
        decoration: const BoxDecoration(
          color: kSecondColor,
          borderRadius: BorderRadius.only(
            topLeft: Radius.circular(16),
            topRight: Radius.circular(16),
          ),
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            const Padding(
              padding: EdgeInsets.all(8.0),
              child: Text("Exames",
                  textAlign: TextAlign.start,
                  style: TextStyle(
                      color: Colors.white,
                      fontWeight: FontWeight.w600,
                      fontSize: 20)),
            ),
            Expanded(
              child: ListView(
                children: const <Widget>[
                  // Insert data from DB here - (description, price, deadline)
                  ExamDataItem("Colesterol", 4.0, 4),
                  ExamDataItem("TSH", 5.0, 6),
                  ExamDataItem("Vitamina C", 10.0, 3),
                  ExamDataItem("Vitamina D", 10.0, 3),
                  ExamDataItem("Vitamina E", 10.0, 3),
                  ExamDataItem("Vitamina F", 10.0, 3),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
