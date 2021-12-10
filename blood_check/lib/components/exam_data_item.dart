import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:blood_check/constants.dart';

class ExamDataItem extends StatefulWidget {
  final String name;
  final double price;
  final int days;

  const ExamDataItem(this.name, this.price, this.days);

  @override
  _ExamDataItemState createState() => _ExamDataItemState();
}

class _ExamDataItemState extends State<ExamDataItem> {
  var _checked = false;

  @override
  Widget build(BuildContext context) {
    return Card(
      color: Colors.white,
      shape: const RoundedRectangleBorder(
        borderRadius: BorderRadius.all(Radius.circular(16)),
      ),
      child: CheckboxListTile(
        value: _checked,
        title: Text(widget.name, style: TextStyle(color: kPrimaryColor)),
        subtitle: Text("R\$ ${widget.price} - prazo: ${widget.days} dias uteis"),
        onChanged: (bool? value) {
          setState(() {
            _checked = value!;
          });
        },
        activeColor: kPrimaryColor,
        checkColor: Colors.white,
      )
    );
  }
}
