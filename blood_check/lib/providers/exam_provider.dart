import 'dart:convert';
import 'package:blood_check/providers/utility.dart';
import 'package:http/http.dart' as http;

class ApiService {
  static Future<List<dynamic>> getExams() async {
    final response = await http.get(Utility.generateUri('exam'));
    return json.decode(response.body);
  }
}
