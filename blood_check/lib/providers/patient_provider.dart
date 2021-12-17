import 'dart:convert';
import 'dart:html';
import 'package:blood_check/providers/utility.dart';
import 'package:http/http.dart' as http;

class ApiService {
  static Future<List<dynamic>> getPatients() async {
    final response = await http.get(Utility.generateUri('patient'));
    return json.decode(response.body);
  }

  static Future<dynamic> postPatient(Map<String, dynamic> body) async {
    final response = await http.post(Utility.generateUri('patient'),
        headers: <String, String>{'Content-Type': 'application/json'},
        body: jsonEncode(body));
    return json.decode(response.body);
  }
}
