// This component is the item (exam) in the requisition screens.

import 'package:blood_check/models/exam_model.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/constants.dart';

class ExamDataItem extends StatefulWidget {
  final Exam_Model exam;
  final setSelected;

  const ExamDataItem(this.exam, this.setSelected);

  @override
  _ExamDataItemState createState() => _ExamDataItemState();
}

class _ExamDataItemState extends State<ExamDataItem>
    with AutomaticKeepAliveClientMixin {
  @override
  bool get wantKeepAlive => true;

  var _checked = false;

  getChecked() => _checked;

  @override
  Widget build(BuildContext context) {
    return Card(
      color: Colors.white,
      shape: const RoundedRectangleBorder(
        borderRadius: BorderRadius.all(Radius.circular(16)),
      ),
      child: CheckboxListTile(
        value: _checked,
        title: Text(widget.exam.description,
            style: const TextStyle(color: kPrimaryColor)),
        subtitle: Text(
            "R\$ ${widget.exam.price} - prazo: ${widget.exam.delivery_days} dias uteis"),
        onChanged: (bool? value) {
          widget.setSelected(widget.exam.id);
          setState(() {
            _checked = value!;
          });
        },
        activeColor: kPrimaryColor,
        checkColor: Colors.white,
      ),
    );
  }
}
