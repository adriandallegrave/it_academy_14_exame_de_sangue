class Patient_Models {
  final int id;
  final String? name;
  final String? cpf;
  final String? phone;

  Patient_Models(this.id, this.name, this.cpf, this.phone);

  @override
  String toString() {
    return 'Patient{id: $id, name: $name, cpf: $cpf, phone: $phone}';
  }
}
