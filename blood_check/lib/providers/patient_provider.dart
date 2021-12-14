import 'dart:convert';
import 'package:http/http.dart' as http;

class ApiService {
  static Future<List<dynamic>> getPatients() async {
    // RESPONSE JSON :
    // [{
    //   "id": "1",
    //   "employee_name": "",
    //   "employee_salary": "0",
    //   "employee_age": "0",
    //   "profile_image": ""
    // }]
    var uriAux = Uri.parse("https://localhost:7288/api/patient");

    //var uriAux = Uri.parse("https://programming-quotes-api.herokuapp.com/quotes");
    final response = await http.get(uriAux);

    /*if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      return response.;
    }
  }*/

    return json.decode(response.body);
  }
}
