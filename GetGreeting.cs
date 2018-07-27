using System.Management.Automation;

namespace HelloWorld
{

    [Cmdlet(VerbsCommon.Get, "Greeting")]
    public class Greeting : PSCmdlet
    {
        private string[] NameCollection;

        [Parameter( Mandatory = true,
                    ValueFromPipeline = true,
                    ValueFromPipelineByPropertyName = true,
                    Position = 0,
                    HelpMessage = "Name of individual to greet")]
        [Alias("Person, Name")]
        public string[] Name {

            get { return NameCollection; }
            set { NameCollection = value; }

        }

        protected override void BeginProcessing() {

            base.BeginProcessing();

        }

        protected override void ProcessRecord() {

            foreach (string Name in NameCollection) {

                WriteVerbose("Creating greeting for " + Name);
                string greeting = "Hello, " + Name;
                WriteObject(greeting);

            }

        }

        protected override void EndProcessing() {

            base.EndProcessing();

        }

    }

}
