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
    return Container(
        margin: EdgeInsets.all(8),
        padding: EdgeInsets.all(8),
        decoration: BoxDecoration(
          color: kSecondColor,
          border: Border.all(color: Colors.transparent),
          borderRadius: BorderRadius.all(Radius.circular(6)),
        ),
        child:
            ListView(padding: const EdgeInsets.all(8), children: const <Widget>[
          ExamDataItem("Colesterol", 4.0, 4),
          ExamDataItem("TSH", 5.0, 6),
          ExamDataItem("Vitamina D", 10.0, 3),
        ])); // Scaffold
  }
}
