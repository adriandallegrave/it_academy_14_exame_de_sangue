import 'dart:convert';
import 'package:blood_check/providers/utility.dart';
import 'package:http/http.dart' as http;

class ApiService {
  static Future<List<dynamic>> getPatients() async {
    final response = await http.get(Utility.generateUri('patient'));
    return json.decode(response.body);
  }

  // TODO: encode patient data into json request body
  // static Future<dynamic> postPatient() async {
  //   final response = await http.post(Utility.generateUri('patient'));
  //   return json.decode(response.body);
  // }
}
