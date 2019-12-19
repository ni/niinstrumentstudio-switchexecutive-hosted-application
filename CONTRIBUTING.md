# Contributing to niinstrumentstudio-switchexecutive-hosted-application 

Contributions to niinstrumentstudio-switchexecutive-hosted-application are welcome from all!

niinstrumentstudio-switchexecutive-hosted-application is managed via [git](https://git-scm.com), with the canonical upstream
repository hosted on [GitHub](https://github.com/ni/<reponame>/).

niinstrumentstudio-switchexecutive-hosted-application follows a pull-request model for development.  If you wish to
contribute, you will need to create a GitHub account, fork this project, push a
branch with your changes to your project, and then submit a pull request.

See [GitHub's official documentation](https://help.github.com/articles/using-pull-requests/) for more details.

# Getting Started

The application is built using VisualStudio 2017 for 64 bit user mode.  The project is included with the source code and can be used to build the assemble.  The output assemble is "SwitchExecutive.Plugin.dll".  That assemble can be copied to c:\users\public\documents\National Instruments\InstrumentStudio <year>\Addons\.  After that hosted applications needs to be enabled from the preferences dialog of InstrumentStudio.  More details can be found at [SwitchExecutive App](https://forums.ni.com/t5/InstrumentStudio/SwitchExecutive-Hosted-Application/gpm-p/3998692?profile.language=en)

# Testing

Integration tests are provided with a VisualStudio project.  The tests require that SwitchExecutive be installed on the system but the tests do not require any hardware.

# Developer Certificate of Origin (DCO)

   Developer's Certificate of Origin 1.1

   By making a contribution to this project, I certify that:

   (a) The contribution was created in whole or in part by me and I
       have the right to submit it under the open source license
       indicated in the file; or

   (b) The contribution is based upon previous work that, to the best
       of my knowledge, is covered under an appropriate open source
       license and I have the right under that license to submit that
       work with modifications, whether created in whole or in part
       by me, under the same open source license (unless I am
       permitted to submit under a different license), as indicated
       in the file; or

   (c) The contribution was provided directly to me by some other
       person who certified (a), (b) or (c) and I have not modified
       it.

   (d) I understand and agree that this project and the contribution
       are public and that a record of the contribution (including all
       personal information I submit with it, including my sign-off) is
       maintained indefinitely and may be redistributed consistent with
       this project or the open source license(s) involved.

(taken from [developercertificate.org](https://developercertificate.org/))

See [LICENSE](https://github.com/ni/<reponame>/blob/master/LICENSE)
for details about how \<reponame\> is licensed.
