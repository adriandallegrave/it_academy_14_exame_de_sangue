

import 'package:blood_check/providers/patient_provider.dart';

class Patient_Model {
  final int? id;
  final String? name;
  final String? cpf;
  final String? phone;

  Patient_Model({this.id, this.name, this.cpf, this.phone});

  @override
  String toString() {
    return 'Patient{id: $id, name: $name, cpf: $cpf, phone: $phone}';
  }

  Future<void> save() async {
    Map<String, dynamic> body = {
      "name": name, 
      "cpf": cpf, 
      "phone": phone
    };
    
    ApiService.postPatient(body);
  }
}
