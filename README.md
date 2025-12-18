# NavCity Toolkit

[![License: CC BY 4.0](https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg)](https://creativecommons.org/licenses/by/4.0/)

A toolkit of open-source spatial navigation tasks for virtual reality research, developed at the **Neural Plasticity Research Lab**.

## Overview

The **NavCity Toolkit** provides researchers with tools to study spatial navigation and allocentric representation formation in immersive virtual environments. The toolkit includes:

- **Familiarization Trial**: A practice/training task to familiarize participants with VR navigation controls
- **NavCity**: A naturalistic, city-like wayfinding task in virtual reality (main experimental task)
- **NARA (NavCity Allocentric Representation Assessment)**: A pen-and-paper assessment of allocentric representations formed during NavCity exposure

This repository contains **two separate Unity projects** (Familiarization Trial and NavCity) along with all source code, assets, and materials needed to implement these tasks in your research.

### Important Note

This toolkit was developed for our lab's specific research needs and may require adaptation for other use cases. The code is provided as-is to support reproducibility and to enable the research community to build upon and improve these tools. **We recommend familiarity with Unity and VR development** if you plan to modify or extend the toolkit.

## Publications

This toolkit has been validated and utilized in the following peer-reviewed publications:

1. **Bassil, Y., Kanukolanu, A., Funderburg, E., Brown, T., & Borich, M. R.** (2026). Formation of allocentric representations after exposure to a novel, naturalistic, city-like, virtual reality environment. *Neuropsychologia*, *220*, 109290. https://doi.org/10.1016/j.neuropsychologia.2025.109290

2. **Bassil, Y., Kanukolanu, A., Funderburg, E., Cui, E., Brown, T., & Borich, M. R.** (2025). Distinct aging-related profiles of allocentric knowledge recall following navigation in an immersive, naturalistic, city-like environment. *PsyArXiv*. https://osf.io/qmwyk

### Citing This Toolkit

If you use the NavCity Toolkit in your research, please cite the primary paper:

```bibtex
@article{bassil2026formation,
  title={Formation of allocentric representations after exposure to a novel, naturalistic, city-like, virtual reality environment},
  author={Bassil, Yasmine and Kanukolanu, Anisha and Funderburg, Elizabeth and Brown, Trisha and Borich, Michael R},
  journal={Neuropsychologia},
  volume={220},
  pages={109290},
  year={2026},
  publisher={Elsevier},
  doi={10.1016/j.neuropsychologia.2025.109290}
}
```

## Features

- **Two Separate Unity Projects**: Familiarization Trial and NavCity task can be deployed independently
- **Naturalistic City-Like Environment**: Explore a city-like virtual environment designed for ecological validity
- **Wayfinding Tasks**: Navigate between landmarks and destinations in an immersive VR setting
- **Allocentric Assessment**: Post-NavCity navigation, evaluate formation of spatial representations with the NARA
- **Open Source**: Full access to Unity project files, scripts, and assets
- **Research-Validated**: Used in published peer-reviewed studies on spatial navigation

## Typical Research Protocol

The toolkit is designed to be used in the following sequence:

1. **Familiarization Trial** (first): Participants practice VR navigation controls in a separate, simpler environment
2. **NavCity Task** (second): Participants complete the main experimental navigation task
3. **NARA Assessment** (third): Participants complete the pen-and-paper allocentric representation assessment

Each Unity project operates independently and should be opened separately in Unity Hub.

## System Requirements

*These requirements apply to both Unity projects (Familiarization Trial and NavCity).*

### Confirmed Requirements
- **Unity Version**: [To be added]
- **VR Headset**: [To be added]
- **Operating System**: [To be added]
- **Additional Dependencies**: [To be added]

### Minimum Specifications (Estimated)
*Note: These are preliminary estimates and may need adjustment based on your specific setup.*

- **Processor**: [TBD]
- **Memory**: [TBD]
- **Graphics**: [TBD]
- **Storage**: [TBD]

> ⚠️ **Help Wanted**: We are working to document comprehensive system requirements. If you successfully run this toolkit, please share your specifications via email (see Contact section below).

## Getting Started

### Prerequisites

- Unity Hub installed
- Compatible VR headset and runtime (e.g., SteamVR, Oculus)
- Basic familiarity with Unity and VR development

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/npresearchlab/NavCity_Toolkit.git
   cd NavCity_Toolkit
   ```

2. **Open a Unity project**
   
   The repository contains **two independent Unity projects**. You can open either one:
   
   - **For the Familiarization Trial:**
     - Launch Unity Hub
     - Click "Add" and select the `NavCity_Toolkit/Familiarization Trial/` folder
     - Open with the appropriate Unity version
   
   - **For the main NavCity task:**
     - Launch Unity Hub
     - Click "Add" and select the `NavCity_Toolkit/NavCity/` folder
     - Open with the appropriate Unity version

3. **Set up VR**
   - Configure your VR headset and runtime
   - Import required VR SDK packages if not already included
   - Test the scene in the Unity Editor

### Quick Start

*Detailed instructions are in development. For now:*

**For Familiarization Trial:**
1. Open the `Familiarization Trial` Unity project (see Installation above)
2. Locate and open the main scene file
3. Connect your VR headset
4. Press Play in the Unity Editor to test

**For NavCity (Main Task):**
1. Open the `NavCity` Unity project (see Installation above)
2. Navigate to the main scene file in the Project window
3. Review the scene hierarchy and key GameObjects
4. Connect your VR headset
5. Press Play in the Unity Editor to test

> **Note**: These are separate Unity projects and must be opened independently. You cannot run both simultaneously in the same Unity instance.

## Repository Structure

This repository contains **two separate Unity projects**, each serving a distinct purpose in the research protocol:

```
NavCity_Toolkit/
├── Familiarization Trial/    # Independent Unity project for practice/training
│   ├── Assets/                # Unity assets, scripts, scenes
│   ├── Packages/              # Unity package dependencies
│   ├── ProjectSettings/       # Unity project configuration
│   └── ...                    # Other Unity project files
│
├── NavCity/                   # Independent Unity project for main experimental task
│   ├── Assets/                # Unity assets, scripts, scenes
│   ├── Packages/              # Unity package dependencies
│   ├── ProjectSettings/       # Unity project configuration
│   └── ...                    # Other Unity project files
│
├── README.md                  # This file
└── license.txt                # CC BY 4.0 license
```

### Project Descriptions

**Familiarization Trial**: A standalone practice environment that allows participants to become comfortable with VR navigation controls before the main experiment. This should typically be run first in your research protocol.

**NavCity**: The main experimental task - a naturalistic, city-like environment where participants perform wayfinding and navigation tasks. This is the primary data collection environment used in the published studies.

## Documentation

Comprehensive documentation is currently in development. For questions about specific implementation details, please refer to:

1. The published papers (see [Publications](#publications) section)
2. Code comments within the Unity scripts
3. Contact the lab directly (see [Contact](#contact) section)

We welcome contributions to improve documentation!

## Known Limitations

- This toolkit was developed for specific research protocols and may require customization for other studies
- Not currently optimized for plug-and-play deployment
- System requirements not fully documented
- Limited setup documentation (we're working on this!)

We encourage the community to fork, modify, and improve this toolkit for their needs.

## Contributing

We welcome contributions from the research community! If you:

- Improve the code or fix bugs
- Add new features or assessments
- Create better documentation
- Identify system requirements

Please consider submitting a pull request or opening an issue on GitHub. All contributions should maintain compatibility with the original research protocols where possible.

## Support and Contact

For questions, bug reports, or collaboration inquiries, please contact:

**Navigation and Plasticity Research Lab**  
📧 nprl.emory@gmail.com  
**Subject line**: "NavCity Inquiry"

Please include:
- Your institutional affiliation
- Brief description of your intended use case
- Specific questions or issues (if applicable)

## License

This toolkit is licensed under the [Creative Commons Attribution 4.0 International License](https://creativecommons.org/licenses/by/4.0/).

You are free to:
- **Share**: Copy and redistribute the material in any medium or format
- **Adapt**: Remix, transform, and build upon the material for any purpose, even commercially

Under the following terms:
- **Attribution**: You must give appropriate credit, provide a link to the license, and indicate if changes were made

See the `license.txt` file for full license text.

## Acknowledgments

This material is based upon work supported by the National Science Foundation Graduate Research Fellowship Program under Grant Nos 1937971 and 2439564. Any opinions, findings, and conclusions or recommendations expressed in this material are those of the authors and do not necessarily reflect the views of the National Science Foundation.

We thank the members of the Neural Plasticity Research Lab who contributed to the development and validation of these tasks.

---

**Last Updated**: December 2024  
**Repository**: https://github.com/npresearchlab/NavCity_Toolkit  
**Lab**: [npresearchlab.com](npresearchlab.com)