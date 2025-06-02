package Week13;

public class ProdConsEx {
	public static void main(String[] args) {
		DataBox dataBox = new DataBox();
		ProducerThread prod = new ProducerThread(dataBox);
		ConsumerThread cons = new ConsumerThread(dataBox);
		
		prod.start();
		cons.start();
		
	}
}
