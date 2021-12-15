// This component presents the checkbox list in the NewRequisition screen.

import 'package:blood_check/models/exam_model.dart';
import 'package:blood_check/providers/exam_provider.dart';
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

  setSelected(int selectedId) {
    if (selectedList.contains(selectedId))
      selectedList.remove(selectedId);
    else
      selectedList.add(selectedId);
    print(selectedList.toString());
  }

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
              child: FutureBuilder(
                  future: getExamData(),
                  builder: (BuildContext context, AsyncSnapshot snapshot) {
                    List<Widget> children;

                    // if response has data
                    if (snapshot.hasData) {
                      List<Exam_Model> exams =
                          Exam_Model.examsFromJson(snapshot.data);

                      List<Widget> exams_widgets = <Widget>[];
                      children = exams_widgets;

                      for (var exam in exams) {
                        exams_widgets.add(ExamDataItem(exam, setSelected));
                      }

                      // if response has error
                    } else if (snapshot.hasError) {
                      children = <Widget>[
                        const Icon(
                          Icons.error_outline,
                          color: Colors.red,
                          size: 60,
                        ),
                        Padding(
                          padding: const EdgeInsets.only(top: 16),
                          child: Text('Error: ${snapshot.error}'),
                        )
                      ];
                      // if theres no response yet
                    } else {
                      children = const <Widget>[
                        SizedBox(
                          width: 60,
                          height: 60,
                          child: CircularProgressIndicator(),
                        ),
                        Padding(
                          padding: EdgeInsets.only(top: 16),
                          child: Text('Awaiting result...'),
                        )
                      ];
                    }

                    return ListView(
                      children: children,
                    );
                  }),
            )
          ],
        ),
      ),
    );
  }

  Future<List<dynamic>> getExamData() async {
    return await ApiService.getExams();
  }
}
