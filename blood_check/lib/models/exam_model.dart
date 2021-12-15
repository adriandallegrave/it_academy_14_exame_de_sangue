class Exam_Model {
  final int id;
  final double price;
  final String description;
  final int delivery_days;

  Exam_Model(this.id, this.price, this.description, this.delivery_days);

  // receives a json obj and instantiates an Exam_Model obj with its data
  Exam_Model.fromJson(Map<String, dynamic> json)
      : id = json['examId'],
        price = json['price'],
        description = json['description'],
        delivery_days = json['deliveryDays'];

  // receives the json list and transforms each obj into an Exam_Model
  static List<Exam_Model> examsFromJson(List<dynamic> json) {
    return List<Exam_Model>.from(json.map((x) => Exam_Model.fromJson(x)));
  } 
  @override
  String toString() {
    return 'Exam{id: $id, price: $price, description: $description, delivery_days: $delivery_days}';
  }
}
