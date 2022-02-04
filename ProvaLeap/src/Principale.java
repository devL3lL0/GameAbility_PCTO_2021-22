public class Principale extends PrincipaleProcessing{

    public static void main(String[] args){
        LeapProcessing lp = new LeapProcessing("Principale");

    }

    @Override
    public void addPAappletComponents() {
        //getHands()[0] is the right hand, getHands()[1] is the left hand.
        text(super.getHands()[0].getDataHand().getCoordPalmProcessing()[0]+"", 200, 200);
    }
}
