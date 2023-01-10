public class XnorLogicalElement : LogicalElement
{
    protected override void ValueSet()
    {
        base.ValueSet();
        outPoints[0].value = (inPoints[0].In != null ? inPoints[0].In.value : 0) != (inPoints[1].In != null ? inPoints[1].In.value : 0) ? (byte)0 : (byte)1;
    }
}
